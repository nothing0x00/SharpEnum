# SharpEnum

This repository contains some basic POC code for a post-exploitation enumeration script written in C#.

The goal of this project is to be the basis for enumeration tradecraft tools that have the following characteristics:
- Can perform enumeration tasks without the use of Powershell
- Can enumerate both local and domain level information
- Is wholly written in C# with minimal dependencies
- Can be compiled into a single standalone executable which can be transfered to the target
- Is opsec safe-ish (work on this aspect is ongoing)

Eventually, the goal of this development project is to fulfill the goals outlined above, through generating the fewest new processes as possible, to limit both logging as well as behavioral heuristics.  Research on the opsec related aspects of this project is ongoing.
This repository may be cloned or modified heavily given time for analysis and research, so expect changes and new editions as time allows.
