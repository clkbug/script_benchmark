#!/usr/bin/env -S scala-cli shebang --quiet

import scala.io.Source
import scala.util.matching.Regex

if args.length != 1 then println("Usage: <script> <filename>")
else
  val filePath = args(0)
  val pattern: Regex = "A(\\d+)".r

  val sum = Source.fromFile(filePath).getLines().foldLeft(0L) { (acc, line) =>
    pattern.findFirstMatchIn(line) match {
      case Some(m) => acc + m.group(1).toLong
      case None    => acc
    }
  }

  println(sum)
