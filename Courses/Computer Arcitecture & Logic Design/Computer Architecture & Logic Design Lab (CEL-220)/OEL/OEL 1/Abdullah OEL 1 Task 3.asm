.data
inputMass: .asciiz "Enter your Mass:"
outputWeight: . asciiz "Your weight on Moon:"
.text
main:
li $v0, 4
la $a0, inputMass
syscall
li $v0, 5
syscall
li $s1, 2
move $s0, $v0
li $v0,4
la $a0, outputWeight
syscall
mul $s2,$s0,$s1
li $v0, 1
syscall
