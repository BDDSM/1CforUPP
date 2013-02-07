
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Упр)
	///</summary>
	public partial class ИзменениеКадровогоПлана:ДокументОбъект
	{
		public DateTime ДатаИзменений;//Дата изменений
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.Перечисления/*Ссылка*/.СостоянияОбъектов УдалитьРешение;//Удалить решение
		public V82.СправочникиСсылка.Организации Организация;
	}
}