import sys
import yaml


def get_product_name(file_path):
    # YAMLファイルの読み込み
    with open(file_path, 'r') as file:
        settings = yaml.safe_load(file)

    # productNameの文字列を取得
    product_name = settings['PlayerSettings']['productName']

    # Unicodeエスケープシーケンスをデコードして文字列に変換
    decoded_product_name = bytes(
        product_name, 'utf-8').decode('unicode_escape')

    # 結果を返す
    return decoded_product_name
