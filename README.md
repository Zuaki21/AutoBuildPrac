# Unityプロジェクト用テンプレート

私がゲーム制作にサッと取り掛かるためのテンプレートプロジェクトです。

このリポジトリを複製してからゲーム制作することをお勧めします。

## 機能

- 自動ビルド機能
- 自動デプロイ機能 ([公開先](https://github.com/Zuaki21/develop))

## 新しくプロジェクトとして始める手順

1. リポジトリを複製する([参考](https://blog.furu07yu.com/entry/github-clone-bare-repository))
2. Github Actionsの"Acquire activation file"ワークフローを実行し、alfを取得([参考](https://zenn.dev/nikaera/articles/unity-gameci-github-actions))
3. [ここ](https://license.unity3d.com/)でUnity License のアクティベーションを行いulfファイルをダウンロードする(PersonalEdition想定でワークフロー書いてるので、PersonalEditionを選ぶ)
4. リポジトリ内のSettingへ移動、シークレットキーとして"UNITY_LICENSE"にulfファイルの中身をペーストする
5. [ここ](https://github.com/settings/tokens)でトークンを生成(Select scopesの"workflow","write:packages"にチェックを入れる)してGithubActionsのシークレットキーに設定する
6. リポジトリ内のSettingへ移動、シークレットキーとして"PERSONAL_ACCESS_TOKEN"にトークンをペーストする
7. リポジトリ名はプロジェクト名として好きに決める
8. Descriptionにゲームの説明を書く
9.  Unity側でプロジェクト名を決め、Pushしたら自動ビルドされます！
10. 素敵なゲー制ライフを！
