# 事前準備

1. リソースグループを作成

    * リソースグループ： `handson-lab-rg`
    * リージョン： `Japan East`

2. 開発仮想マシン作成

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

