﻿Ext.define('Документы.ПоступлениеТоваровУслуг.ФормаОтбораЗаказов',
	{
	extend: 'Ext.window.Window',
	height: 518,width: 783,
	iconCls: 'bogus',
	title: 'Отобрать заказы покупателей',
	
	items: [
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаНач',
			style: 'position:absolute;left:84px;top:17px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ДатаКон',
			style: 'position:absolute;left:188px;top:17px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаНастройкаПериода',
			text: '...',
			style: 'position:absolute;left:276px;top:17px;width:19px;height:19px;',
		},
	]
});