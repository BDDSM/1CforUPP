
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OsnovnyeSredstva")]
	[Route("/Catalogs/OsnovnyeSredstva/{Code}")]
	public class OsnovnyeSredstvaRequest/*����������������������*/: V82.�����������������.����������������,IReturn<OsnovnyeSredstvaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OsnovnyeSredstvaResponse//���������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OsnovnyeSredstvas")]
	[Route("/Catalogs/OsnovnyeSredstvas/{Codes}")]
	public class OsnovnyeSredstvasRequest/*����������������������*/: IReturn<List<OsnovnyeSredstvaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OsnovnyeSredstvasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OsnovnyeSredstvasResponse//���������������������
	{
		public string Result {get;set;}
	}


	public class OsnovnyeSredstvaService /*����������������������*/ : Service
	{
		public object Any(OsnovnyeSredstvaRequest request)
		{
			return new OsnovnyeSredstvaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OsnovnyeSredstvaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������.�����������(���������);
				if (������ == null)
				{
					return new OsnovnyeSredstvaResponse() {Result = "���������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������.�����������(1);
			}
		}

		public object Get(OsnovnyeSredstvasRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������.�����������(���������);
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
