
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Регл)
	///</summary>
	public partial class РасчетыПоНалогуНаПрибыль:ДокументОбъект
	{
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
		public DateTime ПериодРегистрации;//Период регистрации
		///<summary>
		///0- расчет ПНА, ПНО, ОНА, ОНО и налога на прибыль, 1 - ввод остатков по ОНА и ОНО через счет 000, 2 - ввод остатков по ОНА и ОНО через счет 84
		///</summary>
		public decimal/*(10)*/ ВидОперацииРасчетаРазниц;//Вид операции расчета разниц
	}
}