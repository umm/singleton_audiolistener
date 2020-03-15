# What?

* 読み込み済のシーン内に AudioListener が存在しない場合に限り、自動的に AudioListener コンポーネントを生成します。

# Why?

* Additive に読み込む Scene を個別に開発している場合、開発中には AudioListener が居て欲しいという要件があったため。

# Install

### With Unity Package Manager

```bash
upm add package dev.upm-packages.singleton-audiolistener
```

Note: `upm` command is provided by [this repository](https://github.com/upm-packages/upm-cli).

You can also edit `Packages/manifest.json` directly.

```jsonc
{
  "dependencies": {
    // (snip)
    "dev.upm-packages.singleton-audiolistener": "[latest version]",
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
$ npm install github:umm/singleton_audiolistener.git
```

# Usage

* 任意の GameObject に SingletonAudioListener を Add Component するだけです。
  * GameObject は任意ですがメインとなる Camera につけるか、 AudioListener という GameObject を作成することが望ましいでしょう。

# License

Copyright (c) 2017 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)
