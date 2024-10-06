#!/usr/bin/env -S scala-cli shebang --quiet

import scala.io.Source
import scala.util.{Try, Success, Failure}

def readFile(filename: String): Option[Long] =
  val fileSource = Try(Source.fromFile(filename))

  fileSource match
    case Success(source) =>
      try
        val lines = source.getLines().drop(1)
        Some(lines.map(line => line.split('\t').map(_.toLong).sum).sum)
      finally source.close()
    case Failure(_) =>
      None

if args.length < 1 then
  println("Usage: <program> <filename>")
  System.exit(1)

val filename = args(0)
val totalSum = readFile(filename).getOrElse(0)

println(totalSum)
