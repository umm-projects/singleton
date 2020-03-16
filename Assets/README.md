# What?

* Singleton なアクセスを可能にする static アクセサを提供します。

# Why?

* シンプルな Singleton 機構を作りたかったので作りました。

# Install

### With Unity Package Manager

```bash
upm add package dev.upm-packages.singleton
```

Note: `upm` command is provided by [this repository](https://github.com/upm-packages/upm-cli).

You can also edit `Packages/manifest.json` directly.

```jsonc
{
  "dependencies": {
    // (snip)
    "dev.upm-packages.singleton": "[latest version]",
    // (snip)
  },
  "scopedRegistries": [
    {
      "name": "Unofficial Unity Package Manager Registry",
      "url": "https://upm-packages.dev",
      "scopes": [
        "dev.upm-packages"
      ]
    }
  ]
}
```

### Any other else (classical umm style)

```shell
$ npm install github:umm/singleton
```

# Usage

```csharp
using UnityEngine;
using UnityModule;

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
