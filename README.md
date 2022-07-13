# benthos-poc


## Run

> docker run --rm -p 8080:4195 --name benthos-container-producer --network benthos-network --link broker -d  -v C:\dev\benthos-poc\config_httpServer_kafkaOutput.yaml:/benthos.yaml jeffail/benthos

> docker run --rm --name benthos-container-consumer --network benthos-network --link broker -v C:\dev\benthos-poc\config_KafkaInput_httpClient.yaml:/benthos.yaml jeffail/benthos


> docker run --rm --name benthos-container --network benthos-network --link broker -v C:\dev\benthos-poc\config.yaml:/benthos.yaml jeffail/benthos

## Endpoints

## Payload

```json
{
    "id": "1",
    "content": "Teste de envio de mensagem",
    "register": "2022-07-12 17:00:00"
}
```

### API 

https://localhost:7264/payload

### Benthos

http://127.0.0.1:8080/post


## Test

> siege -c50 -r2 -d1 --content-type "application/json" 'http://127.0.0.1:8080/post POST {"id": "1","content": "mensagem para voce"}'

