// COLOR SCHEME TEST "gruvbox/gruvbox (Dark) (Medium).sublime-color-scheme" "C#"

using System;
// ^^ fg=#fb4934 fs=
//    ^^^^^^^ fg=#fbf1c7 fs=

using System.Windows.Forms;
// ^^ fg=#fb4934 fs=
//    ^^^^^^^^^^^^^^^^^^^^^ fg=#fbf1c7 fs=

class Program
// ^^ fg=#fb4934 fs=
//    ^^^^^^^ fg=#fabd2f fs=

{
    const double PI = 3.14;
//  ^^^^^ fg=#fb4934 fs=
//        ^^^^^^ fg=#fb4934 fs=
//               ^^ fg=#83a598 fs=
//                  ^ fg=#8ec07c fs=
//                    ^^^^ fg=#d3869b fs=
//                        ^ fg=#fbf1c7 fs=

    public int X;
//  ^^^^^^ fg=#fb4934 fs=
//         ^^^ fg=#fb4934 fs=
//             ^ fg=#83a598 fs=
//              ^ fg=#fbf1c7 fs=

    int x = 37;
//  ^^^ fg=#fb4934 fs=
//      ^ fg=#83a598 fs=
//        ^ fg=#8ec07c fs=
//          ^^ fg=#d3869b fs=
//            ^ fg=#fbf1c7 fs=

    int[] x(int y) {return x + y;}
//  ^^^ fg=#fb4934 fs=
//     ^^ fg=#fbf1c7 fs=
//        ^ fg=#b8bb26 fs=
//         ^ fg=#fbf1c7 fs=
//          ^^^ fg=#fb4934 fs=
//              ^^ fg=#fbf1c7 fs=
//                 ^ fg=#fbf1c7 fs=
//                  ^^^^^^ fg=#fb4934 fs=
//                         ^ fg=#83a598 fs=
//                           ^ fg=#8ec07c fs=
//                             ^ fg=#83a598 fs=
//                              ^^ fg=#fbf1c7 fs=

    abcd () {}
//  ^^^^ fg=#b8bb26 fs=
//       ^^ fg=#fbf1c7 fs=
//          ^^ fg=#fbf1c7 fs=

    X (string x) : base () { Console.WriteLine("ab"); }
//  ^ fg=#b8bb26 fs=
//    ^ fg=#fbf1c7 fs=
//     ^^^^^^ fg=#fb4934 fs=
//            ^^ fg=#fbf1c7 fs=
//               ^ fg=#fbf1c7 fs=
//                 ^^^^ fg=#d3869b fs=
//                      ^^ fg=#fbf1c7 fs=
//                         ^ fg=#fbf1c7 fs=
//                           ^^^^^^^ fg=#83a598 fs=
//                                  ^ fg=#fbf1c7 fs=
//                                   ^^^^^^^^^ fg=#8ec07c fs=
//                                            ^^ fg=#fbf1c7 fs=
//                                              ^^ fg=#b8bb26 fs=
//                                                ^^^ fg=#fbf1c7 fs=
//                                                    ^ fg=#fbf1c7 fs=

    void x([Usage("ab")] int x, int y)
//  ^^^^ fg=#fb4934 fs=
//       ^ fg=#b8bb26 fs=
//        ^^ fg=#fbf1c7 fs=
//          ^^^^^ fg=#83a598 fs=
//               ^^ fg=#fbf1c7 fs=
//                 ^^ fg=#b8bb26 fs=
//                   ^^^ fg=#fbf1c7 fs=
//                       ^^^ fg=#fb4934 fs=
//                           ^^ fg=#fbf1c7 fs=
//                              ^^^ fg=#fb4934 fs=
//                                  ^^ fg=#fbf1c7 fs=

    static void Main(string[] x){}
//  ^^^^^^ fg=#fbf1c7 fs=
//         ^^^^ fg=#fb4934 fs=
//              ^^^^ fg=#b8bb26 fs=
//                  ^ fg=#fbf1c7 fs=
//                   ^^^^^^ fg=#fb4934 fs=
//                         ^^ fg=#fbf1c7 fs=
//                            ^^^^ fg=#fbf1c7 fs=
}

string verbatim = @"ab "" cd";
// ^^^ fg=#fb4934 fs=
//     ^^^^^^^^ fg=#83a598 fs=
//              ^ fg=#8ec07c fs=
//                ^^ fg=#fbf1c7 fs=
//                  ^^ fg=#b8bb26 fs=
//                     ^^ fg=#fb4934 fs=
//                        ^^ fg=#b8bb26 fs=
//                          ^^ fg=#fbf1c7 fs=

    public class GenericList<T> {
//  ^^^^^^ fg=#fb4934 fs=
//         ^^^^^ fg=#fb4934 fs=
//               ^^^^^^^^^^^ fg=#fabd2f fs=
//                          ^ fg=#fbf1c7 fs=
//                           ^ fg=#fabd2f fs=
//                            ^ fg=#fbf1c7 fs=
//                              ^ fg=#fbf1c7 fs=

    void Add(T i) { } }
//  ^^^^ fg=#fb4934 fs=
//       ^^^ fg=#b8bb26 fs=
//          ^ fg=#fbf1c7 fs=
//           ^ fg=#fabd2f fs=
//             ^^ fg=#fbf1c7 fs=
//                ^ fg=#fbf1c7 fs=
//                  ^ fg=#fbf1c7 fs=
//                    ^ fg=#fbf1c7 fs=

class InheritingSomething: IYourInterface {}
// ^^ fg=#fb4934 fs=
//    ^^^^^^^^^^^^^^^^^^^ fg=#fabd2f fs=
//                       ^ fg=#fbf1c7 fs=
//                         ^^^^^^^^^^^^^^ fg=#fabd2f fs=
//                                        ^ fg=#fbf1c7 fs=

class WithGeneric<T1, T2> where T1: IEnumerable<T2> {}
// ^^ fg=#fb4934 fs=
//    ^^^^^^^^^^^ fg=#fabd2f fs=
//               ^ fg=#fbf1c7 fs=
//                ^^ fg=#fabd2f fs=
//                  ^ fg=#fbf1c7 fs=
//                    ^^ fg=#fabd2f fs=
//                      ^ fg=#fbf1c7 fs=
//                        ^^^^^ fg=#fb4934 fs=
//                              ^^ fg=#fabd2f fs=
//                                ^ fg=#fbf1c7 fs=
//                                  ^^^^^^^^^^^ fg=#fabd2f fs=
//                                             ^ fg=#fbf1c7 fs=
//                                              ^^ fg=#fabd2f fs=
//                                                ^ fg=#fbf1c7 fs=
//                                                  ^^ fg=#fbf1c7 fs=
