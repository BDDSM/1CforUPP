
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/GruppyDostupnostiSkladov")]
	[Route("/Catalogs/GruppyDostupnostiSkladov/{Code}")]
	public class GruppyDostupnostiSkladovRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<GruppyDostupnostiSkladovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class GruppyDostupnostiSkladovResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/GruppyDostupnostiSkladovs")]
	[Route("/Catalogs/GruppyDostupnostiSkladovs/{Codes}")]
	public class GruppyDostupnostiSkladovsRequest/*������������������������������*/: IReturn<List<GruppyDostupnostiSkladovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public GruppyDostupnostiSkladovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class GruppyDostupnostiSkladovsResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class GruppyDostupnostiSkladovService /*������������������������������*/ : Service
	{
		public object Any(GruppyDostupnostiSkladovRequest request)
		{
			return new GruppyDostupnostiSkladovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(GruppyDostupnostiSkladovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new GruppyDostupnostiSkladovResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(GruppyDostupnostiSkladovsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
