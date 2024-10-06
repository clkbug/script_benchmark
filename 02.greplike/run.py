import sys
import re

with open(sys.argv[1]) as fp:
    s = 0
    for i, l in enumerate(fp):
        m = re.search(r"A(\d+)", l)

        if m is None:
            continue
        x = m.groups()[0]
        s += int(x)
    print(s)
