.data
.text
li $t0, 0x10
srl $t1,$t0,4
li $v0, 1
move $a0, $t1
syscall
li $v0, 10
syscall
