# CommunityDiscussionLayout.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`6555D85248C9D564A0DF5389AA2378D32CD47C123EEAFB0BD200248B8FAEE00D`。来源：[源码](../../CommunityDiscussionLayout.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.CommunityDiscussionLayout`、`NationalSpire.CommunityDiscussionLayout.Item`。

字段、事件及初始值（源码原样）：

```csharp

```

<a id="symbol-a01512e18826"></a>

## `NationalSpire.CommunityDiscussionLayout.Item.Reply — public CommunityReply Reply`

来源：源码第 8 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-591698a1620e"></a>

## `NationalSpire.CommunityDiscussionLayout.Item.Parent — public Item? Parent`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-09f3822aee26"></a>

## `NationalSpire.CommunityDiscussionLayout.Item.Floor — public int Floor`

来源：源码第 10 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-652899f2a9c7"></a>

## `NationalSpire.CommunityDiscussionLayout.Item.Depth — public int Depth`

来源：源码第 11 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityDiscussionLayout.Item.Depth`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-f71d0ec34bcc"></a>

## `NationalSpire.CommunityDiscussionLayout.Item.Visible — public bool Visible`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-052a29a8af14"></a>

## `NationalSpire.CommunityDiscussionLayout.Item.Descendants — public int Descendants`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** 无已绑定项目字段引用。

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**


<a id="symbol-abc2f068bbc7"></a>

## `NationalSpire.CommunityDiscussionLayout.Build(NationalSpire.CommunityPost, System.Collections.Generic.IReadOnlySet<string>) — public static List<Item> Build(CommunityPost post, IReadOnlySet<string> collapsed)`

来源：源码第 16 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.RenderDiscussion(NationalSpire.CareerData, NationalSpire.CommunityPost, Godot.VBoxContainer)`](CommunityScreen.cs.md#symbol-1799ee450143)

**调用：** `NationalSpire.CommunityDiscussionLayout.Item.Item(NationalSpire.CommunityReply, NationalSpire.CommunityDiscussionLayout.Item?, int, bool)`；[`NationalSpire.CommunityThreads.ReadingOrder(NationalSpire.CommunityPost)`](CommunityThreads.cs.md#symbol-7120f3e9af63)；`System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；`System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；`System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；`System.Collections.Generic.List<T>.Add(T)`；`System.Collections.Generic.List<T>.List(int)`

**字段、属性、事件及方法组引用：** `NationalSpire.CommunityDiscussionLayout.Item.Descendants`；`NationalSpire.CommunityDiscussionLayout.Item.Floor`；`NationalSpire.CommunityDiscussionLayout.Item.Parent`；`NationalSpire.CommunityDiscussionLayout.Item.Reply`；`NationalSpire.CommunityDiscussionLayout.Item.Visible`；`NationalSpire.CommunityPost.Replies`；`NationalSpire.CommunityReply.Id`；`NationalSpire.CommunityReply.ParentId`；`NationalSpire.CommunityThreads.ReadingOrder(NationalSpire.CommunityPost)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CommunityDiscussionLayout.Item.Item(NationalSpire.CommunityReply, NationalSpire.CommunityDiscussionLayout.Item?, int, bool)`；输入表达式：`new Item(reply, parent, parent?.Floor ?? ++floor, parent == null || parent.Visible && !collapsed.Contains(parent.Reply.Id))`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Item(reply, parent, parent?.Floor ?? ++floor, parent == null || parent.Visible && !collapsed.Contains(parent.Reply.Id))`
- `NationalSpire.CommunityThreads.ReadingOrder(NationalSpire.CommunityPost)`；输入表达式：`CommunityThreads.ReadingOrder(post)`；返回值紧邻使用处：`ForEachStatementSyntax: foreach (var reply in CommunityThreads.ReadingOrder(post)) { // 沿既有阅读顺序绑定已出现的父节点；缺失父节点或循环引用作为独立入口显示。 byId.TryGetValue(reply.ParentId, out var parent); var item = new Item(reply, parent, parent?.Floor ?? ++floor, parent == null || parent.Visible && !collapsed.Contains(parent.Reply.Id)); items.Add(item); byId[reply.Id] = item; }`
- `System.Collections.Generic.Dictionary<TKey, TValue>.Dictionary()`；输入表达式：`new Dictionary<string, Item>()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new Dictionary<string, Item>()`
- `System.Collections.Generic.Dictionary<TKey, TValue>.TryGetValue(TKey, out TValue)`；输入表达式：`byId.TryGetValue(reply.ParentId, out var parent)`；返回值紧邻使用处：`ExpressionStatementSyntax: byId.TryGetValue(reply.ParentId, out var parent);`
- `System.Collections.Generic.IReadOnlySet<T>.Contains(T)`；输入表达式：`collapsed.Contains(parent.Reply.Id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !collapsed.Contains(parent.Reply.Id)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`items.Add(item)`；返回值紧邻使用处：`ExpressionStatementSyntax: items.Add(item);`
- `System.Collections.Generic.List<T>.List(int)`；输入表达式：`new List<Item>(post.Replies.Count)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new List<Item>(post.Replies.Count)`

**赋值（含属性/字段和局部值）：**

- `byId[reply.Id]` = `item`
- `parent.Descendants` += `items[i].Descendants + 1`
