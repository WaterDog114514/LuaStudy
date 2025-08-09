method1 = function()
	print("无参无返回值")
end

function method2(t1)
	print("有参数无返回值" ..t1)
end

local biao = {}
function biao.fanhui()
	return "返回了个大巴"
end
method3 = biao.fanhui