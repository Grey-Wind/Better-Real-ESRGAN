const cmdShell = require('node-cmd')

console.log('Hello world');

function cmd(domainName: string) {
    /**
     * @description: ���� cmd ��ʹ��cmd����
     * @param {*}
     * @return {*}
     */

    // �л������ʽ -> utf8
    cmdShell.get(
        "chcp 65001",
        function (err: string, data: string, stderr: string) {
            console.log('��������: ', data)
        }
    )

    cmdShell.get(
        /**
         * @err��������Ϣ
         * @data��cmd������Ϣ
         * @stderr��ִ�нű�������Ϣ
         */
        // ��Ҫִ�е�����
        `ping ${domainName}`,
        function (err: string, data: string, stderr: string) {
            console.log('��������: ', data)
            // console.log('��������: ', err)
            // console.log('��������: ', stderr)
        }
    )

    // ��������
    cmdShell.run("cmd.exe /c")
}

cmd("ipconfig");
