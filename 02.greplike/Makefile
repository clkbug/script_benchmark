.PHONY: all cpython pypy scala fsharp

all: cpython pypy scala fsharp go

cpython: run.py
	hyperfine 'python run.py ../data/text_1024MiB.txt '
pypy: run.py
	hyperfine 'pypy3 run.py ../data/text_1024MiB.txt '

scala: run.sc
	hyperfine 'scala-cli run.sc -- ../data/text_1024MiB.txt '

fsharp: run.fsx
	hyperfine 'dotnet fsi run.fsx ../data/text_1024MiB.txt '

go: run.go
	hyperfine 'go run run.go ../data/text_1024MiB.txt '
