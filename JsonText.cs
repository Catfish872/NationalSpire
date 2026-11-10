using System.Text;
using System.Text.Json;

namespace NationalSpire;

/// <summary>流式读取存档文本，兼容旧文本读取器支持的 Unicode 字节序标记。</summary>
internal static class JsonText
{
    internal static T? Read<T>(Stream input, JsonSerializerOptions options)
    {
        byte[] prefix = new byte[4];
        int count = input.ReadAtLeast(prefix, prefix.Length, throwOnEndOfStream: false);
        var (encoding, skip) = EncodingOf(prefix.AsSpan(0, count));
        using var content = new PrefixStream(input, prefix.AsMemory(skip, count - skip));
        if (encoding == Encoding.UTF8) return JsonSerializer.Deserialize<T>(content, options);
        using var utf8 = Encoding.CreateTranscodingStream(content, encoding, Encoding.UTF8, leaveOpen: true);
        return JsonSerializer.Deserialize<T>(utf8, options);
    }

    private static (Encoding Encoding, int Skip) EncodingOf(ReadOnlySpan<byte> prefix)
    {
        // UTF-32 LE 与 UTF-16 LE 共用前两个字节，先检查四字节标记。
        if (prefix is [0xff, 0xfe, 0, 0]) return (Encoding.UTF32, 4);
        if (prefix is [0, 0, 0xfe, 0xff]) return (new UTF32Encoding(true, true), 4);
        if (prefix is [0xff, 0xfe, ..]) return (Encoding.Unicode, 2);
        if (prefix is [0xfe, 0xff, ..]) return (Encoding.BigEndianUnicode, 2);
        if (prefix is [0xef, 0xbb, 0xbf, ..]) return (Encoding.UTF8, 3);
        return (Encoding.UTF8, 0);
    }

    // ZIP 条目支持顺序读取；把检测时已读的正文放回流前端，调用方继续持有原流。
    private sealed class PrefixStream(Stream source, ReadOnlyMemory<byte> prefix) : Stream
    {
        private int _position;
        public override int Read(Span<byte> buffer)
        {
            int count = Math.Min(buffer.Length, prefix.Length - _position);
            if (count == 0) return source.Read(buffer);
            prefix.Span.Slice(_position, count).CopyTo(buffer);
            _position += count;
            return count;
        }
        public override int Read(byte[] buffer, int offset, int count) => Read(buffer.AsSpan(offset, count));
        public override bool CanRead => source.CanRead;
        public override bool CanSeek => false;
        public override bool CanWrite => false;
        public override long Length => throw new NotSupportedException();
        public override long Position { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
        public override void Flush() { }
        public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
        public override void SetLength(long value) => throw new NotSupportedException();
        public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
    }
}
