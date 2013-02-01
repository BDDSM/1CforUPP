﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class ПрочиеЗатраты:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыОперацийПрочиеЗатраты ВидОперации;//Вид операции
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
		///<summary>
		///(Регл)
		///</summary>
		public object Счет;
		///<summary>
		///(Регл)
		///</summary>
		public object Субконто1;//Субконто 1
		///<summary>
		///(Регл)
		///</summary>
		public object Субконто2;//Субконто 2
		///<summary>
		///(Регл)
		///</summary>
		public object Субконто3;//Субконто 3
		///<summary>
		///(Регл)
		///</summary>
		public object СчетНУ;//Счет (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУ1;//Субконто 1 (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУ2;//Субконто 2 (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУ3;//Субконто 3 (налоговый учет)
		public object Проект;
	}
}
