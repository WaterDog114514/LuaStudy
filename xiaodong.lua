
biao = {
	longvalue = 23,
	shuchu = function(t1,t2)
		return t1,t2
	end
}
function biao.baba(par1,par2)
	print("你好" .. biao.longvalue)
	coroutine.yield(par1+par2) 
	print("继续执行")
end
local co = coroutine.create(biao.baba)
print(coroutine.resume(co,2,3))
coroutine.resume(co)