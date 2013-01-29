
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Byudzhety")]
	[Route("/Catalogs/Byudzhety/{Code}")]
	public class ByudzhetyRequest/*�������������*/: V82.�����������������.�������,IReturn<ByudzhetyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ByudzhetyResponse//������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Byudzhetys")]
	[Route("/Catalogs/Byudzhetys/{Codes}")]
	public class ByudzhetysRequest/*�������������*/: IReturn<List<ByudzhetyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ByudzhetysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ByudzhetysResponse//������������
	{
		public string Result {get;set;}
	}


	public class ByudzhetyService /*�������������*/ : Service
	{
		public object Any(ByudzhetyRequest request)
		{
			return new ByudzhetyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ByudzhetyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������.�����������(���������);
				if (������ == null)
				{
					return new ByudzhetyResponse() {Result = "������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������.�����������(1);
			}
		}

		public object Get(ByudzhetysRequest request)
		{
			var ��������� = new List<V82.�����������������.�������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������.�����������(���������);
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
