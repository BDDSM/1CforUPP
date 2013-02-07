
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	public partial class ВыгрузкаРегламентированныхОтчетов:ДокументОбъект
	{
		public DateTime ПериодПо;//Период По
		public V82.СправочникиСсылка.Организации Организация;
		public string/*(4)*/ КодИМНС;//Код ИФНС
		public string/*(0)*/ Комментарий;
		public bool флОтборИФНС;//Фл отбор ИФНС
	}
}