.data
inputPrompt1: .asciiz "Enter your Birth Year: "
inputPrompt2: .asciiz "Enter the current year: "
outputPrompt1: .asciiz "Your age is: "
.text
main:
li $v0, 4
la $a0, inputPrompt1
syscall
li $v0, 5
syscall
move $s0 , $v0
li $v0, 4
la $a0, inputPrompt2
syscall
li $v0, 5
syscall
move $s1 , $v0
li $v0, 4
la $a0, outputPrompt1
syscall
sub $s2 , $s1, $s0
li $v0, 1
move $a0, $s2
syscall
li $v0, 10
syscall
