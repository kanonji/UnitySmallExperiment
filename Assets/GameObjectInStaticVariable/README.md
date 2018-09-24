## static変数に値を入れると、シーン遷移後も値が残っているかどうか

Method|result
---|---
`public static GameObject go;`|遷移後はnull
`public static string str;`|遷移後も参照可能
`public static BarClass barClass;`|遷移後も参照可能
`public static BazStruct bazStruct;`|遷移後も参照可能

やってみたら当たり前だけど、GameObjectは遷移後にHierarchyに残ってないのでnullになってしまった。
stringの様な値, classインスタンスやstructなら、シーン遷移後も参照可能。
