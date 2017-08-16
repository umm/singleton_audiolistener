# What?

* 読み込み済のシーン内に AudioListener が存在しない場合に限り、自動的に AudioListener コンポーネントを生成します。

# Why?

* Additive に読み込む Scene を個別に開発している場合、開発中には AudioListener が居て欲しいという要件があったため。

# Install

```shell
$ npm install @umm/singleton_audiolistener
```

# Usage

* 任意の GameObject に SingletonAudioListener を Add Component するだけです。
  * GameObject は任意ですがメインとなる Camera につけるか、 AudioListener という GameObject を作成することが望ましいでしょう。

# License

Copyright (c) 2017 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)

