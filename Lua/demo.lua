local zuzhong = {
	waigua = "外挂"
}
local biao = {
	name = "longbiao",
	list = {"longgou","shuigou"}


}
function biao:DaYe()
	print(self.name .. "在打野")
end
local erzi={
	feiji = "飞机"
}
setmetatable(erzi,biao)
biao.__index = biao
biao.__newindex = zuzhong
erzi.laobao = "老宝贝"
print(erzi["name"])

for i,k in pairs(erzi) do
	print(i,k)
end