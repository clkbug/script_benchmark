package main

import (
	"bufio"
	"fmt"
	"os"
	"regexp"
	"strconv"
)

func main() {
	fp, _ := os.Open(os.Args[1])
	buf := bufio.NewScanner(fp)
	s := uint64(0)
	pattern := regexp.MustCompile(`A(\d+)`)
	for buf.Scan() {
		l := buf.Text()
		match := pattern.FindStringSubmatch(l)
		if match == nil {
			continue
		}
		num, _ := strconv.Atoi(match[1])
		s += uint64(num)
	}
	fmt.Println(s)
}
