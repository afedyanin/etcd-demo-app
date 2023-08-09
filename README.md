# etcd-demo-app

## ETCD resources

- [ETCD project](https://etcd.io/)
- [Quikstart](https://etcd.io/docs/v3.5/quickstart/)
- [Docker ETCD cluster](https://github.com/garutilorenzo/docker-etcd-cluster/tree/master)
- [C# gRPC client](https://github.com/shubhamranjan/dotnet-etcd)

## Run ETCD cluster

```
docker-compose up -d
```

## Ñheck the status of the cluster environment

```
docker-compose ps
```


## Command line tests

- [donload etcdctl](https://github.com/etcd-io/etcd/releases/)

### Put

```
etcdctl put greeting "Hello, etcd"
```

### Get

```
etcdctl get greeting
```


### C# Console sample
 
Just run solution or console project

```
dotnet run --project src\EtcdConsoleApp
```





