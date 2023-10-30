.data
outPrompt: .asciiz "you are out of loop"

.text
li $t0, 0 #i

dowhile:
   beq $t0, 10, out
   move $a0, $t0
   li $v0, 1
   syscall
   addi $t0, $t0, 1
   
out:
  la $a0, outPrompt
  li $v0, 4
  syscall
  li $v0, 10
  syscall