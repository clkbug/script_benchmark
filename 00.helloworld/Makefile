.PHONY: all cpython pypy scala fsharp

all: cpython pypy scala fsharp

cpython: run.py
	hyperfine 'python run.py'
pypy: run.py
	hyperfine 'pypy3 run.py'

scala: run.sc
	hyperfine 'amm run.sc'

fsharp: run.fsx
	hyperfine 'dotnet fsi run.fsx'
