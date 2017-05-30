## GameObject.Find(), Transform.Find()

> This function only returns active GameObjects.
> [Unity \- Scripting API: GameObject\.Find](https://docs.unity3d.com/ScriptReference/GameObject.Find.html)

`GameObject.Find()`は非アクティブなゲームオブジェクトを見つけられないとある。
[Unity \- Scripting API: Transform\.Find](https://docs.unity3d.com/ScriptReference/Transform.Find.html)にはその記述がなく、非アクティブなゲームオブジェクトも取得出来る様に思える。


Method|result
---|---
GameObject.Find("Active")|o
GameObject.Find("Inactive")|x
this.Parent.transform.Find("Active Child")|o
this.Parent.transform.Find("Inactive Child")|o
this.Parent.transform.Find("/Active")|o
this.Parent.transform.Find("/Inactive")|x

`Transform.Find()`はstaticメソッドでは無いので、基本子オブジェクトを取得するのに使うし、非アクティブでも取得できる。
しかし`/`を付けて絶対パスにすると、挙動は`GameObject.Find()`の様になる。非アクティブなゲームオブジェクトは取得出来なかった。
