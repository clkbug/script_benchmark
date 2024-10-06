import sys

with open(sys.argv[1]) as fp:
    s = 0
    for i, l in enumerate(fp):
        if i == 0:
            continue
        w = map(int, l.strip().split('\t'))
        s += sum(w)
    print(s)
