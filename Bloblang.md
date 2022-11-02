# Bloblang


# Editor interativo

```
docker pull jeffail/benthos:latest
docker run -p 4195:4195 --rm jeffail/benthos blobl server --no-open --host 0.0.0.0
```

Será exibido um aplicativo com três painéis, o canto superior esquerdo é onde você cola um documento de entrada, o inferior é o mapeamento do Bloblang e no canto superior direito está a saída.

Acessar em: http://localhost:4195



## INPUT

> {"message":"hello world 2", "isTrue": true, "total": 10, "type": null}


# Mapping



```

root = this
root.message = "Other value " + this.message.uppercase().replace_all("WORLD", "EARTH")
root.payload.content = "new message"
root.message = deleted()

let id = uuid_v4()
root.id = $id
root.id_hashSHA1 = $id.hash("sha1").encode("hex")
root.id_hashMD5 = $id.hash("md5").encode("hex")

root.total = if this.isTrue {
  this.total + 10
} else {
  this.total -5
}
```



 