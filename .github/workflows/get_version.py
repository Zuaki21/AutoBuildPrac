import re


def get_editor_version(file_path):
    with open(file_path, 'r') as f:
        contents = f.read()

    pattern = r'm_EditorVersionWithRevision:\s+(\S+)'
    match = re.search(pattern, contents)
    if match:
        version = match.group(1)
        return version
    else:
        return None
