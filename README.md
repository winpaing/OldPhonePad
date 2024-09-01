# OldPhonePad

This C# program simulates the input method of old mobile phones that used a keypad to type text. It decodes numeric input sequences into their corresponding letters according to the T9 keypad standard. The program also supports backspacing (`*`) and sending (`#`) operations.

## Features

- **Key Mappings:** The program uses standard key mappings for the T9 keypad, where each digit represents multiple characters:
  - `2` -> A, B, C
  - `3` -> D, E, F
  - `4` -> G, H, I
  - `5` -> J, K, L
  - `6` -> M, N, O
  - `7` -> P, Q, R, S
  - `8` -> T, U, V
  - `9` -> W, X, Y, Z
- **Backspace (`*`):** Removes the last character entered.
- **Send (`#`):** Finalizes the input sequence.
- **Input Validation:** Ensures only valid sequences are processed.

## Prerequisites

- **.NET SDK:** Make sure you have the .NET SDK installed on your Mac. You can install it using Homebrew:

  ```bash
  brew install --cask dotnet-sdk

C# Compiler: The program uses the csc C# compiler, which is included with the .NET SDK

## Usage
- Clone this git file to your local machine's desktop:

## Run the Program
```bash
cd ~/Desktop/OldPhonePadApp
dotnet run
```
## Enter Key Sequences:
Input numbers as you would on an old mobile keypad.
Press Y to decode another sequence or N to exit.
## Example
```bash
Enter Number: 227*#
Results is : B
Continue Y/N: Y
Enter Number: 33#
Results is : E
Continue Y/N: Y
Enter Number: 222 2 22
Results is : C A B
Continue Y/N: Y
Enter Number: 4433555 555666#
Results is : HEL LO
Continue Y/N: Y
Enter Number: 8 88777444666*664#
Results is : T URING
Continue Y/N: Y
```



