
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DenezhnyeDokumenty")]
	[Route("/Catalogs/DenezhnyeDokumenty/{Code}")]
	public class DenezhnyeDokumentyRequest/*�����������������������*/: V82.�����������������.�����������������,IReturn<DenezhnyeDokumentyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DenezhnyeDokumentyResponse//����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DenezhnyeDokumentys")]
	[Route("/Catalogs/DenezhnyeDokumentys/{Codes}")]
	public class DenezhnyeDokumentysRequest/*�����������������������*/: IReturn<List<DenezhnyeDokumentyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DenezhnyeDokumentysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DenezhnyeDokumentysResponse//����������������������
	{
		public string Result {get;set;}
	}


	public class DenezhnyeDokumentyService /*�����������������������*/ : Service
	{
		public object Any(DenezhnyeDokumentyRequest request)
		{
			return new DenezhnyeDokumentyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DenezhnyeDokumentyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������.�����������(���������);
				if (������ == null)
				{
					return new DenezhnyeDokumentyResponse() {Result = "����������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������.�����������(1);
			}
		}

		public object Get(DenezhnyeDokumentysRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������.�����������(���������);
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
