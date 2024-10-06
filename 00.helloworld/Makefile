.PHONY: all cpython pypy scala fsharp go

all: cpython pypy scala fsharp go

cpython: run.py
	hyperfine 'python run.py'
pypy: run.py
	hyperfine 'pypy3 run.py'

scala: run.sc
	hyperfine 'amm run.sc'

fsharp: run.fsx
	hyperfine 'dotnet fsi run.fsx'

go: run.go
	hyperfine 'go run run.go'