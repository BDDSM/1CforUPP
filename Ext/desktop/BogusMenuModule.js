/*!
* Ext JS Library 4.0
* Copyright(c) 2006-2011 Sencha Inc.
* licensing@sencha.com
* http://www.sencha.com/license
*/

Ext.define('MyDesktop.BogusMenuModule', {
    extend: 'MyDesktop.BogusModule',

    init: function () {

        this.launcher = {
            text: '�����������',
            iconCls: 'bogus',
            handler: function () {
                return false;
            },
            menu: {
                items: []
            }
        };
        
            Ext.Loader.setConfig({ //������������ ���������� ��������
                enabled: true,  //��������� �������
                disableCaching: true,   //�� �������� �����
                paths: {
                    Base: "js/Base", //���� � ������������ ������ Base
                    ����������: "����������",
                    �����������: "�����������",
                    ���������: "���������",
                }
            });
            //alert(src.FormId);
            var ����������� = Ext.create("����������.�����������");
            for (var ���������������� = 0, ����������; ���������� = �����������[����������������]; ����������������++)
            {
                this.launcher.menu.items.push({
                    text: ����������.���,
                    iconCls: 'bogus',
                    handler: this.createWindow,
                    scope: this,
                    windowId: ++windowIndex,
                    FormId: '�����������.' + ����������.��� + '.�������������'
                });
                
                if (���������������� > 20)
                {
                    break;
                }
                
            }
        


    }
});

Ext.define('MyDesktop.BogusMenuModule1', {
    extend: 'MyDesktop.BogusModule',

    init: function () {

        this.launcher = {
            text: '���������',
            iconCls: 'bogus',
            handler: function () {
                return false;
            },
            menu: {
                items: []
            }
        };

        Ext.Loader.setConfig({ //������������ ���������� ��������
            enabled: true,  //��������� �������
            disableCaching: true,   //�� �������� �����
            paths: {
                Base: "js/Base", //���� � ������������ ������ Base
                ����������: "����������",
                �����������: "�����������",
                ���������: "���������",
            }
        });
        //alert(src.FormId);
        var ��������� = Ext.create("����������.���������");
        for (var �������������� = 0, ��������; �������� = ���������[��������������]; ��������������++) {
            this.launcher.menu.items.push({
                text: ��������.���,
                iconCls: 'bogus',
                handler: this.createWindow,
                scope: this,
                windowId: ++windowIndex,
                FormId: '���������.' + ��������.��� + '.��������������'
            });

            if (�������������� > 20)
            {
                break;
            }

        }
    }
});
