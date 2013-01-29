
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/GruppyPochtovojjRassylki")]
	[Route("/Catalogs/GruppyPochtovojjRassylki/{Code}")]
	public class GruppyPochtovojjRassylkiRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<GruppyPochtovojjRassylkiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class GruppyPochtovojjRassylkiResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/GruppyPochtovojjRassylkis")]
	[Route("/Catalogs/GruppyPochtovojjRassylkis/{Codes}")]
	public class GruppyPochtovojjRassylkisRequest/*����������������������������*/: IReturn<List<GruppyPochtovojjRassylkiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public GruppyPochtovojjRassylkisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class GruppyPochtovojjRassylkisResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class GruppyPochtovojjRassylkiService /*����������������������������*/ : Service
	{
		public object Any(GruppyPochtovojjRassylkiRequest request)
		{
			return new GruppyPochtovojjRassylkiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(GruppyPochtovojjRassylkiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new GruppyPochtovojjRassylkiResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(GruppyPochtovojjRassylkisRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������.�����������(���������);
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
