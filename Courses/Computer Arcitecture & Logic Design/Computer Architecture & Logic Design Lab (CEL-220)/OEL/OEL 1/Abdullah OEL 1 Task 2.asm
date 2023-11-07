.data
inputNumber: .asciiz "Enter the number of Fibonacci nembers you want to generate:"
outputSeries: .asciiz "Fibonacci series is:"
NumberSpace: .space 2

.text
main:
li $v0, 4
la $a0, inputNumber
syscall
li $v0, 8
la $a0, NumberSpace
li $a1, 2
syscall
li $a2, 8
la $a0, outputSeries
syscall
add $a2,$a0,$a1
li $v0, 1
move $a0, $s2
syscall
 
