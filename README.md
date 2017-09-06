# What?

* Singleton なアクセスを可能にする static アクセサを提供します。

# Why?

* シンプルな Singleton 機構を作りたかったので作りました。

# Install

```shell
$ npm install github:umm-projects/singleton
```

# Usage

```csharp
using UnityEngine;

public class SampleSingleton : Singleton<SampleSingleton> {

    public string Hoge = "ほげ";

}

public class Sample {

    public void Run() {
        Debug.Log(SampleSingleton.Instance.Hoge);
    }

}
```

* `Singleton<T>` を継承したクラスを作るだけです。
* `<T>` には作成するクラスをそのまま用います。

# License

Copyright (c) 2017 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)

