// Intent: Lets you split a large class or a set of closely related classes into
// two separate hierarchies—abstraction and implementation—which can be
// developed independently of each other.
//
//               A
//            /     \                        A         N
//          Aa      Ab        ===>        /     \     / \
//         / \     /  \                 Aa(N) Ab(N)  1   2
//       Aa1 Aa2  Ab1 Ab2

using BridgeLibrary.DevicesAndRemotesExample;
using BridgeLibrary.DocumentsAndFormattersExample;

DeviceAndRemotesExecutor.Execute();
DocumentsAndFormattersExecutor.Execute();
