const cmdShell = require('node-cmd')

console.log('Hello world');

function cmd(domainName: string) {
    /**
     * @description: 连接 cmd ，使用cmd命令
     * @param {*}
     * @return {*}
     */

    // 切换编码格式 -> utf8
    cmdShell.get(
        "chcp 65001",
        function (err: string, data: string, stderr: string) {
            console.log('数据详情: ', data)
        }
    )

    cmdShell.get(
        /**
         * @err：报错信息
         * @data：cmd返回信息
         * @stderr：执行脚本返回信息
         */
        // 需要执行的命令
        `ping ${domainName}`,
        function (err: string, data: string, stderr: string) {
            console.log('数据详情: ', data)
            // console.log('数据详情: ', err)
            // console.log('数据详情: ', stderr)
        }
    )

    // 运行命令
    cmdShell.run("cmd.exe /c")
}

cmd("ipconfig");
