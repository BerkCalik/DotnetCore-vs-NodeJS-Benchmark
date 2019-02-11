# DotnetCore-vs-NodeJS-Benchmark
## Basic Dotnet Core and Node.js Web API Http Request Test



Clone Repo
```sh
$ git clone https://github.com/BerkCalik/DotnetCore-vs-NodeJS-Benchmark.git
$ cd DotnetCore-vs-NodeJS-Benchmark
```

# Node.JS

### How To Start
Install [Node.js](https://nodejs.org/)
```sh
$ cd node
$ npm install
$ npm start
```
You can create http request to http://localhost:3000/values

# Dotnet Core
### How To Start
Install [Dotnet Core](https://dotnet.microsoft.com/download)
```sh
$ cd dotnet
$ dotnet build
$ dotnet run -c release
```
You can create http request to http://localhost:5000/api/values

# WRK | Http Testing
Install [Wrk Tool](https://github.com/wg/wrk)
### My Test Configs (you can change)
 - 25 thread
 - 500 connection
 - 10s duration

#### Node.js Test & Result
```sh
$ wrk -t25 -c500 -d10s http://localhost:3000/values

Running 10s test @ http://localhost:3000/values
  25 threads and 500 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    41.61ms    9.31ms 174.37ms   83.50%
    Req/Sec   402.44    112.38     0.88k    80.10%
  100489 requests in 10.08s, 23.38MB read
  Socket errors: connect 0, read 497, write 0, timeout 0
Requests/sec:   9972.90
Transfer/sec:   2.32MB
```

#### Dotnet Core Test & Result
```sh
$ wrk -t25 -c500 -d10s http://localhost:5000/api/values

Running 10s test @ http://localhost:5000/api/values
  25 threads and 500 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    11.80ms    8.51ms 322.71ms   94.59%
    Req/Sec     1.65k   364.83     4.81k    85.24%
  413804 requests in 10.11s, 75.38MB read
  Socket errors: connect 0, read 419, write 0, timeout 0
Requests/sec:  40950.42
Transfer/sec:  7.46MB
```

### My Computer Specs
 - iMac (27-inch, Mid 2011)
 - 3.4 GHz Intel Core i7
 - 16 GB 1333 MHz DDR3
 - SSD



