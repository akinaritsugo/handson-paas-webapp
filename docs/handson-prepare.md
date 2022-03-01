# 事前準備

1. リソースグループを作成

    * リソースグループ： `handson-lab-rg`
    * リージョン： `Japan East`

2. 仮想ネットワーク作成

    * VNet

        |名前|CIDR|
        |---|---|
        | `main-vnet` | `10.0.0.0/16`

    * Subnet

        |名前|CIDR|
        |---|---|
        | `dev-vm-sub` | `10.0.99.0/24`

2. 開発仮想マシン作成

    * 仮想マシン名： `win-vm`
    * Windows 10 Pro, version 20H2 - Gen2
    * ユーザー名、パスワードは本番で使うのでメモしておく

3. 開発仮想マシンの環境準備

    * GitHubのソースコードをダウンロード

        https://github.com/akinaritsugo/handson-paas-webapp

        →ダウンロードしたファイルは「 `Documents` 」に配置しておく

    * SQL Server Management Studio のインストール

        https://docs.microsoft.com/ja-jp/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15#available-languages

    * Visual Studio 2019 Community のインストール

        https://visualstudio.microsoft.com/ja/downloads/

          * Workloads
              * ASP.NET
              * Azure
              * Data storage and processing
          * Language Packs
              * Japanese

      `Web開発` で一度起動する
      [Tool]-[Options]を開き、[Environment]-[International Settings]で言語を「日本語」に変更

    * スタートメニューに以下のショートカットを入れておく

        * SQL Server Management Studio (SSMS)
        * Visual Studio 2022 Community

