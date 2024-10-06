package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
	"strings"
)

func main() {
	fp, _ := os.Open(os.Args[1])
	buf := bufio.NewScanner(fp)
	s := uint64(0)
	for buf.Scan() {
		l := buf.Text()
		w := strings.Split(l, "\t")
		for _, x := range w {
			n, _ := strconv.Atoi(x)
			s += uint64(n)
		}
	}
	fmt.Println(s)
}
