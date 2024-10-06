.PHONY: all cpython pypy scala fsharp

all: cpython pypy scala fsharp go

cpython: run.py
	hyperfine 'python run.py ../data/tsv_0010000000line.tsv'
pypy: run.py
	hyperfine 'pypy3 run.py ../data/tsv_0010000000line.tsv'

scala: run.sc
	hyperfine 'scala-cli run.sc -- ../data/tsv_0010000000line.tsv'

fsharp: run.fsx
	hyperfine 'dotnet fsi run.fsx ../data/tsv_0010000000line.tsv'

go: run.go
	hyperfine 'go run run.go ../data/tsv_0010000000line.tsv'
