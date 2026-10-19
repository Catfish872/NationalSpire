# GroupAvatar.cs

[返回文件依赖索引](../SOURCE_MAP.md)

源码 SHA-256：`2A62385A751A568AC9DE5D67850D0B5E86534A2E0E3103895DD23211DCFB42D0`。来源：[源码](../../GroupAvatar.cs)。匿名函数计入所属成员，局部函数单列；静态调用没有表达执行条件和先后次序。属性可能有副作用。

## 类型与字段

类型：`NationalSpire.GroupAvatar`。

字段、事件及初始值（源码原样）：

```csharp
private readonly List<CareerAvatar> _pictures = [];
```

<a id="symbol-821b26d40593"></a>

## `NationalSpire.GroupAvatar.Members(NationalSpire.CareerData, NationalSpire.GroupChat) — public static string[] Members(CareerData data, GroupChat group)`

来源：源码第 9 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupAvatar.Update(NationalSpire.CareerData, NationalSpire.GroupChat)`](GroupAvatar.cs.md#symbol-5d97e2be271b)

**调用：** [`NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`](CareerEngine.cs.md#symbol-e88f87203328)；[`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`](GroupChats.cs.md#symbol-24bc82bdbbd4)；`System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；`System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；`System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；`NationalSpire.GroupChat.Members`；`NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `NationalSpire.CareerEngine.Person(NationalSpire.CareerData, string)`；输入表达式：`CareerEngine.Person(data, id)`；返回值紧邻使用处：`BinaryExpressionSyntax: CareerEngine.Person(data, id) != null`
- `NationalSpire.GroupChats.IsHuman(NationalSpire.CareerData, string)`；输入表达式：`GroupChats.IsHuman(data, id)`；返回值紧邻使用处：`PrefixUnaryExpressionSyntax: !GroupChats.IsHuman(data, id)`
- `System.Collections.Generic.IEnumerable<TSource>.Distinct<TSource>(System.Collections.Generic.IEqualityComparer<TSource>?)`；输入表达式：`group.Members.Distinct(StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Members.Distinct(StringComparer.Ordinal) .Where`
- `System.Collections.Generic.IEnumerable<TSource>.OrderBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`group.Members.Distinct(StringComparer.Ordinal) .Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null) .OrderBy(id => id, StringComparer.OrdinalIgnoreCase)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Members.Distinct(StringComparer.Ordinal) .Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null) .OrderBy(id => id, StringComparer.OrdinalIgnoreCase).ThenBy`
- `System.Collections.Generic.IEnumerable<TSource>.Take<TSource>(int)`；输入表达式：`group.Members.Distinct(StringComparer.Ordinal) .Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null) .OrderBy(id => id, StringComparer.OrdinalIgnoreCase).ThenBy(id => id, StringComparer.Ordinal).Take(4)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Members.Distinct(StringComparer.Ordinal) .Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null) .OrderBy(id => id, StringComparer.OrdinalIgnoreCase).ThenBy(id => id, StringComparer.Ordinal).Take(4).ToArray`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`group.Members.Distinct(StringComparer.Ordinal) .Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null) .OrderBy(id => id, StringComparer.OrdinalIgnoreCase).ThenBy(id => id, StringComparer.Ordinal).Take(4).ToArray()`；返回值紧邻使用处：`ArrowExpressionClauseSyntax: => group.Members.Distinct(StringComparer.Ordinal) .Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null) .OrderBy(id => id, StringComparer.OrdinalIgnoreCase).ThenBy(id => id, StringComparer.Ordinal).Take(4).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`group.Members.Distinct(StringComparer.Ordinal) .Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Members.Distinct(StringComparer.Ordinal) .Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null) .OrderBy`
- `System.Linq.IOrderedEnumerable<TSource>.ThenBy<TSource, TKey>(System.Func<TSource, TKey>, System.Collections.Generic.IComparer<TKey>?)`；输入表达式：`group.Members.Distinct(StringComparer.Ordinal) .Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null) .OrderBy(id => id, StringComparer.OrdinalIgnoreCase).ThenBy(id => id, StringComparer.Ordinal)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: group.Members.Distinct(StringComparer.Ordinal) .Where(id => !GroupChats.IsHuman(data, id) && CareerEngine.Person(data, id) != null) .OrderBy(id => id, StringComparer.OrdinalIgnoreCase).ThenBy(id => id, StringComparer.Ordinal).Take`

**赋值（含属性/字段和局部值）：**


<a id="symbol-f26071d5307b"></a>

## `NationalSpire.GroupAvatar._Ready() — public override void _Ready()`

来源：源码第 12 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** 无已绑定显式调用。

**字段、属性、事件及方法组引用：** `NationalSpire.GroupAvatar.Arrange()`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**


**赋值（含属性/字段和局部值）：**

- `MouseFilter` = `MouseFilterEnum.Ignore`
- `Resized` += `Arrange`

<a id="symbol-5d97e2be271b"></a>

## `NationalSpire.GroupAvatar.Update(NationalSpire.CareerData, NationalSpire.GroupChat) — public void Update(CareerData data, GroupChat group)`

来源：源码第 13 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.CareerScreen.ShowPrivateListRows()`](PrivateListRows.cs.md#symbol-a42f68b15faf)

**调用：** `Godot.CanvasItem.Hide()`；`Godot.CanvasItem.QueueRedraw()`；`Godot.CanvasItem.Show()`；`Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；`NationalSpire.CareerAvatar.CareerAvatar()`；[`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`](CareerAvatars.cs.md#symbol-cd3d95caefab)；[`NationalSpire.GroupAvatar.Arrange()`](GroupAvatar.cs.md#symbol-b80fa1ee586a)；[`NationalSpire.GroupAvatar.Members(NationalSpire.CareerData, NationalSpire.GroupChat)`](GroupAvatar.cs.md#symbol-821b26d40593)；`System.Collections.Generic.List<T>.Add(T)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerAvatar.Art`；`NationalSpire.CareerAvatar.PersonId`；`NationalSpire.CareerAvatar.Simplified`；`NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；`NationalSpire.GroupAvatar.Arrange()`；`NationalSpire.GroupAvatar.Members(NationalSpire.CareerData, NationalSpire.GroupChat)`；`NationalSpire.GroupAvatar._pictures`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.Hide()`；输入表达式：`_pictures[i].Hide()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pictures[i].Hide();`
- `Godot.CanvasItem.QueueRedraw()`；输入表达式：`QueueRedraw()`；返回值紧邻使用处：`ExpressionStatementSyntax: QueueRedraw();`
- `Godot.CanvasItem.Show()`；输入表达式：`_pictures[i].Show()`；返回值紧邻使用处：`ExpressionStatementSyntax: _pictures[i].Show();`
- `Godot.Node.AddChild(Godot.Node, bool, Godot.Node.InternalMode)`；输入表达式：`AddChild(picture)`；返回值紧邻使用处：`ExpressionStatementSyntax: AddChild(picture);`
- `NationalSpire.CareerAvatar.CareerAvatar()`；输入表达式：`new CareerAvatar { Simplified = true }`；返回值紧邻使用处：`EqualsValueClauseSyntax: = new CareerAvatar { Simplified = true }`
- `NationalSpire.CareerAvatars.ForPerson(NationalSpire.CareerData, string)`；输入表达式：`CareerAvatars.ForPerson(data, ids[i])`；返回值紧邻使用处：`AssignmentExpressionSyntax: _pictures[i].Art = CareerAvatars.ForPerson(data, ids[i])`
- `NationalSpire.GroupAvatar.Arrange()`；输入表达式：`Arrange()`；返回值紧邻使用处：`ExpressionStatementSyntax: Arrange();`
- `NationalSpire.GroupAvatar.Members(NationalSpire.CareerData, NationalSpire.GroupChat)`；输入表达式：`Members(data, group)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Members(data, group)`
- `System.Collections.Generic.List<T>.Add(T)`；输入表达式：`_pictures.Add(picture)`；返回值紧邻使用处：`ExpressionStatementSyntax: _pictures.Add(picture);`

**赋值（含属性/字段和局部值）：**

- `Simplified` = `true`
- `_pictures[i].Art` = `CareerAvatars.ForPerson(data, ids[i])`
- `_pictures[i].PersonId` = `ids[i]`

<a id="symbol-b80fa1ee586a"></a>

## `NationalSpire.GroupAvatar.Arrange() — private void Arrange()`

来源：源码第 24 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** [`NationalSpire.GroupAvatar.Update(NationalSpire.CareerData, NationalSpire.GroupChat)`](GroupAvatar.cs.md#symbol-5d97e2be271b)

**调用：** `Godot.Vector2.Vector2(float, float)`；`System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；`System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；`System.Math.Min(float, float)`

**字段、属性、事件及方法组引用：** `NationalSpire.GroupAvatar._pictures`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2((edge - half) / 2, 0)`；返回值紧邻使用处：`ConditionalExpressionSyntax: i == 0 ? new Vector2((edge - half) / 2, 0) : new Vector2((i - 1) * (half + gap), half + gap)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2((i - 1) * (half + gap), half + gap)`；返回值紧邻使用处：`ConditionalExpressionSyntax: i == 0 ? new Vector2((edge - half) / 2, 0) : new Vector2((i - 1) * (half + gap), half + gap)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(i % 2 * (half + gap), i / 2 * (half + gap))`；返回值紧邻使用处：`SwitchExpressionArmSyntax: _ => new Vector2(i % 2 * (half + gap), i / 2 * (half + gap))`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(i * (half + gap), (edge - half) / 2)`；返回值紧邻使用处：`SwitchExpressionArmSyntax: 2 => new Vector2(i * (half + gap), (edge - half) / 2)`
- `System.Collections.Generic.IEnumerable<TSource>.ToArray<TSource>()`；输入表达式：`_pictures.Where(p => p.Visible).ToArray()`；返回值紧邻使用处：`EqualsValueClauseSyntax: = _pictures.Where(p => p.Visible).ToArray()`
- `System.Collections.Generic.IEnumerable<TSource>.Where<TSource>(System.Func<TSource, bool>)`；输入表达式：`_pictures.Where(p => p.Visible)`；返回值紧邻使用处：`MemberAccessExpressionSyntax: _pictures.Where(p => p.Visible).ToArray`
- `System.Math.Min(float, float)`；输入表达式：`Math.Min(Size.X, Size.Y)`；返回值紧邻使用处：`EqualsValueClauseSyntax: = Math.Min(Size.X, Size.Y)`

**赋值（含属性/字段和局部值）：**

- `visible[i].Position` = `position`
- `visible[i].Size` = `Vector2.One * (visible.Length == 1 ? edge : half)`

<a id="symbol-7d1ac12346aa"></a>

## `NationalSpire.GroupAvatar._Draw() — public override void _Draw()`

来源：源码第 40 行。签名列出参数、默认值和返回类型。输出业务用途见流程文档。

**调用者：** 未发现已绑定直接调用；仍需检查方法组、事件、反射和游戏入口。

**调用：** `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；`Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；`Godot.CanvasItem.DrawStyleBox(Godot.StyleBox, Godot.Rect2)`；`Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；`Godot.Vector2.Vector2(float, float)`；[`NationalSpire.CareerVisuals.Box(string, string, int, int)`](CareerVisuals.cs.md#symbol-96a89aa3b493)；`System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`

**字段、属性、事件及方法组引用：** `NationalSpire.CareerVisuals.Box(string, string, int, int)`；`NationalSpire.CareerVisuals.Teal`；`NationalSpire.GroupAvatar._pictures`

**调用输入与返回值使用（源码表达式，不推测运行条件）：**

- `Godot.CanvasItem.DrawArc(Godot.Vector2, float, float, float, int, Godot.Color, float, bool)`；输入表达式：`DrawArc(Size / 2 + new Vector2(0, 10), 9, Mathf.Pi, Mathf.Tau, 16, CareerVisuals.Teal, 3, true)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawArc(Size / 2 + new Vector2(0, 10), 9, Mathf.Pi, Mathf.Tau, 16, CareerVisuals.Teal, 3, true);`
- `Godot.CanvasItem.DrawCircle(Godot.Vector2, float, Godot.Color)`；输入表达式：`DrawCircle(Size / 2 - new Vector2(0, 5), 5, CareerVisuals.Teal)`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawCircle(Size / 2 - new Vector2(0, 5), 5, CareerVisuals.Teal);`
- `Godot.CanvasItem.DrawStyleBox(Godot.StyleBox, Godot.Rect2)`；输入表达式：`DrawStyleBox(CareerVisuals.Box("203448", "526b78", 6, 0), new(Vector2.Zero, Size))`；返回值紧邻使用处：`ExpressionStatementSyntax: DrawStyleBox(CareerVisuals.Box("203448", "526b78", 6, 0), new(Vector2.Zero, Size));`
- `Godot.Rect2.Rect2(Godot.Vector2, Godot.Vector2)`；输入表达式：`new(Vector2.Zero, Size)`；返回值紧邻使用处：`ArgumentSyntax: new(Vector2.Zero, Size)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 10)`；返回值紧邻使用处：`BinaryExpressionSyntax: Size / 2 + new Vector2(0, 10)`
- `Godot.Vector2.Vector2(float, float)`；输入表达式：`new Vector2(0, 5)`；返回值紧邻使用处：`BinaryExpressionSyntax: Size / 2 - new Vector2(0, 5)`
- `NationalSpire.CareerVisuals.Box(string, string, int, int)`；输入表达式：`CareerVisuals.Box("203448", "526b78", 6, 0)`；返回值紧邻使用处：`ArgumentSyntax: CareerVisuals.Box("203448", "526b78", 6, 0)`
- `System.Collections.Generic.IEnumerable<TSource>.Any<TSource>(System.Func<TSource, bool>)`；输入表达式：`_pictures.Any(p => p.Visible)`；返回值紧邻使用处：`IfStatementSyntax: if (_pictures.Any(p => p.Visible)) return;`

**赋值（含属性/字段和局部值）：**
