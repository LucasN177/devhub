-- Feature requests submitted from the project detail pages.
-- Anonymous visitors may only insert; reading is restricted to the dashboard / service role.

create table if not exists public.feature_requests
(
    id           bigint generated always as identity primary key,
    project_slug text        not null,
    name         text        not null check (char_length(trim(name)) between 1 and 100),
    message      text        not null check (char_length(trim(message)) between 1 and 2000),
    created_at   timestamptz not null default now()
);

create index if not exists feature_requests_project_slug_idx
    on public.feature_requests (project_slug, created_at desc);

alter table public.feature_requests enable row level security;

grant insert on table public.feature_requests to anon, authenticated;

drop policy if exists "Anyone can submit feature requests" on public.feature_requests;
create policy "Anyone can submit feature requests"
    on public.feature_requests
    for insert
    to anon, authenticated
    with check (true);
