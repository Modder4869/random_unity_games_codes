import firecontrol  # the generated single file
from flatbuffers import Table

with open('SubpackageBundleInfo.fb', 'rb') as f:
    buf = f.read()

info = firecontrol.SubpackageInfoFB.GetRootAsSubpackageInfoFB(buf, 0)


num_chunks = info.ChunksLength()
for i in range(num_chunks):
    chunk = info.Chunks(i)
    # print(chunk.Tag())
    # print(chunk.FileName())
    filename = chunk.FileName().decode('utf-8')
    print(f"https://net-cdn.hecategames.com/prod/android/subpackage/{filename}")