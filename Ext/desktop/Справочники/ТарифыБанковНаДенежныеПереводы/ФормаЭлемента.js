﻿Ext.define('Справочники.ТарифыБанковНаДенежныеПереводы.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	height: 168,width: 400,
	iconCls: 'bogus',
	title: 'Тарифы банков',
	
	items: [
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Код',
			style: 'position:absolute;left:312px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:98px;top:33px;width:181px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'МинимальныйТариф',
			style: 'position:absolute;left:130px;top:91px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'МаксимальныйТариф',
			style: 'position:absolute;left:130px;top:116px;width:100px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Процент',
			style: 'position:absolute;left:130px;top:62px;width:100px;height:19px;',
		},
	]
});