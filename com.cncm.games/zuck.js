var un=Module.load("/data/app/com.DefaultCompany.MeiTest-GeKLMzjGT9zLS7QMEG1Ewg\=\=/lib/arm64/libunity.so")
un.base.add(0x4e9d6c)
var ZUC_Init = new NativeFunction(un.base.add(0x4e9d6c),"pointer",["pointer","pointer","pointer"])
this.state=Memory.alloc(16);new NativeFunction(un.base.add(0x4e9d6c),"pointer"
,["pointer","pointer","pointer"])(this.state,un.base.add(0x18191e8),un.base.add(0x13ef5c0))
var ZUC_gene=new NativeFunction(un.base.add(0x4e9df8),"pointer",["pointer","pointer","uint32"])
this.ks=Memory.alloc(40);ZUC_gene(this.state,this.ks,40)
fhex(this.state,160)
fhex(this.ks,40)

