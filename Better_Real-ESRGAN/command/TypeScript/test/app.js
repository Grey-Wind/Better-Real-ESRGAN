const cmdShell = require('node-cmd');
console.log('Hello world');
function cmd(domainName) {
    /**
     * @description: ???? cmd ?????cmd????
     * @param {*}
     * @return {*}
     */
    // ?л??????? -> utf8
    cmdShell.get("chcp 65001", function (err, data, stderr) {
        console.log('数据详情: ', data);
    });
    cmdShell.get(
    /**
     * @err?????????
     * @data??cmd???????
     * @stderr????н?????????
     */
    // ?????е?????
    `ping ${domainName}`, function (err, data, stderr) {
        console.log('数据详情: ', data);
        // console.log('????????: ', err)
        // console.log('????????: ', stderr)
    });
    // ????????
    cmdShell.run("cmd.exe /c");
}
cmd("ipconfig");
//# sourceMappingURL=app.js.map