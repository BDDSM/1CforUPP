﻿Ext.define('Документы.ЧекККМ.ФормаАвторизации',
	{
	extend: 'Ext.window.Window',
	height: 84,width: 468,
	iconCls: 'bogus',
	title: 'Авторизация: Введите пароль или прочитайте регистрационную карту',
	
	items: [
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Пользователь',
			style: 'position:absolute;left:117px;top:8px;width:343px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Пароль',
			style: 'position:absolute;left:117px;top:32px;width:343px;height:19px;',
		},
	]
});