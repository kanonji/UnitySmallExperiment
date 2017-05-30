# Variable Initializer

* `UnityEngine.Random`はフィールドの初期化には使えない。
* Prefabのインスタンスかどうかは影響しない。

## Normal field (serialized)

```cs
[SerializeField] private float systemRandomRange = (new System.Random()).Next(100);
or
public float publicSystemRandomRange = (new System.Random()).Next(100);
```

* SerializeFieldは、コンポーネントをアタッチした時に`Random()`が動いて、値が決定する。様に思える挙動をする。
* コンポーネントを`reset`すると、再度`Random()`が動いて値が変わる。
* Unityエディタで再生したタイミングでは`Random()`が動いていない。


## static field

```cs
private static float staticSystemRandomRange = (new System.Random()).Next(100);
```

* Unityエディタで再生したタイミングで`Random()`が動いている様子。
