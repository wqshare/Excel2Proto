import time
import os

cwd = os.getcwd()
os.system(r'ProtoGen\protogen.exe -i:ActivitySet.proto -o:test.cs -ns:wwww -p:binary=true')
print 'finished'
time.sleep(4)