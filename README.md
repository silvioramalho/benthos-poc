# benthos-poc


## Run

> docker run --rm -p 8080:4195 --name benthos-container-producer --network benthos-network --link broker -d  -v C:\dev\poc-benthos\config_httpServer_kafkaOutput.yaml:/benthos.yaml jeffail/benthos

> docker run --rm --name benthos-container-consumer -d --network benthos-network --link broker -v C:\dev\poc-benthos\config_KafkaInput_httpClient.yaml:/benthos.yaml jeffail/benthos

> docker run --rm --name benthos-container-consumer --network benthos-network --link broker -v C:\dev\poc-benthos\config_kafkaMultipleConsumer_httpClient.yaml:/benthos.yaml jeffail/benthos


> docker run --rm -p 8080:4195 --name benthos-container --network benthos-network --link broker -v C:\dev\poc-benthos\config.yaml:/benthos.yaml jeffail/benthos

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

> siege -c50 -r100 -d0 --content-type "application/json" 'http://127.0.0.1:8080/post POST {"id": "1","content": "mensagem para voce"}'

## Count requests in API

https://learn.microsoft.com/en-us/dotnet/core/diagnostics/dotnet-counters


### Install tool

> dotnet tool install --global dotnet-counters

> 

> dotnet-counters monitor --process-id 21044 --counters Microsoft.AspNetCore.Hosting[requests-per-second] --format csv -o log_requests.log

> dotnet-counters monitor --counters Microsoft.AspNetCore.Hosting[requests-per-second] --refresh-interval 1 --format csv --name BenthosPOC.API





docker run --rm --name benthos-container-consumer-1 --network benthos-network -d --link broker -v C:\dev\benthos-poc\config_KafkaInput_httpClient.yaml:/benthos.yaml jeffail/benthos
docker run --rm --name benthos-container-consumer-2 --network benthos-network -d --link broker -v C:\dev\benthos-poc\config_KafkaInput_httpClient.yaml:/benthos.yaml jeffail/benthos
docker run --rm --name benthos-container-consumer-3 --network benthos-network -d --link broker -v C:\dev\benthos-poc\config_KafkaInput_httpClient.yaml:/benthos.yaml jeffail/benthos
docker run --rm --name benthos-container-consumer-4 --network benthos-network -d --link broker -v C:\dev\benthos-poc\config_KafkaInput_httpClient.yaml:/benthos.yaml jeffail/benthos
docker run --rm --name benthos-container-consumer-5 --network benthos-network -d --link broker -v C:\dev\benthos-poc\config_KafkaInput_httpClient.yaml:/benthos.yaml jeffail/benthos